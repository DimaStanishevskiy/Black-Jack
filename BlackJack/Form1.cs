using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //глобальные переменные которые управляют ходом игры
        // значенние меняется при нажатии кнопок "дальше" и "пас"
        bool contin = false;
        bool alternative = false;

        private void startButton_Click(object sender, EventArgs e)
        {
            //Проверяем правильно ли заданны макс и мин для ставки, если да то блокируем доступ к настройкам игры 
            // и запускаем основной код как фоновый поток, если нет то сообщаем об ошибке
            if (Convert.ToInt32(maxRateBox.Text) >= Convert.ToInt32(minRateBox.Text))
            {
                backgroundWorker.RunWorkerAsync();
                maxRateBox.ReadOnly = true;
                minRateBox.ReadOnly = true;
                startMoneyBox.ReadOnly = true;
                countDeckBox.ReadOnly = true;
                startButton.Enabled = false;
            }
            else statusBox.Text = "Максимальная ставка меньше чем минимальная";

        }

        //функция для трансформации масива игральных карт в строку для отображенния в текстовом поле
        string cardToString(int[] masCards)
        {
            string str = "";
            for (int i = 0; i < 11; i++)
            {
                switch (masCards[i])
                {
                    case 1:
                        str = str + "T ";
                        break;
                    case 2:
                        str = str + "2 ";
                        break;
                    case 3:
                        str = str + "3 ";
                        break;
                    case 4:
                        str = str + "4 ";
                        break;
                    case 5:
                        str = str + "5 ";
                        break;
                    case 6:
                        str = str + "6 ";
                        break;
                    case 7:
                        str = str + "7 ";
                        break;
                    case 8:
                        str = str + "8 ";
                        break;
                    case 9:
                        str = str + "9 ";
                        break;
                    case 10:
                        str = str + "10 ";
                        break;
                    case 11:
                        str = str + "В ";
                        break;
                    case 12:
                        str = str + "Д ";
                        break;
                    case 13:
                        str = str + "К ";
                        break;
                }
            }
            return str;
        }

        //функция для подсчета очков в игрока и дилера, учитывает возможность разного значения для туза в зависимости от переполнения
        int countRate(int[] masCards)
        {
            int rate = 0;
            bool overflow = false;
            for (int i = 0; i < 11; i++)
            {
                if (masCards[i] == 1)
                    if (overflow) rate += 1;
                    else rate += 11;
                else if (masCards[i] < 10) rate += masCards[i];
                else rate += 10;

                if ((rate > 21) & (!overflow))
                {
                    overflow = true;
                    i = -1;
                    rate = 0;
                }
            }
            return rate;
        }

        //функция для формирования колоды карт(их порядка) принимает как аргументы масив для хранения порядка карт и количество игральных колод
        //возвращает общее количество карт
        int generationCardsStack(int[] cardsStack, int countDeck)
        {
            //масив для хранение количества не внесенных в колоду карт по номиналах
            int[] masCountCards = new int[13];
            int countCards = countDeck * 52;
            for (int i = 0; i < 13; i++)
                masCountCards[i] = countDeck * 4;

            Random rand = new Random();

            for (int i = 0; i < countCards; i++)
            {
                bool flag = true;
                while (flag)
                {
                    int temp = rand.Next(1, 14);
                    //проверяем остались ли не внесенные карты даного номинала
                    if (masCountCards[temp - 1] > 0)
                    {
                        flag = false;
                        cardsStack[i] = temp;
                        masCountCards[temp - 1]--;
                    }
                }
            }
            return countCards;
        }

        //функция позволяет приостановить выполненние програмы, что бы игрок смог принять решение и уследить за ходом игры
        void pauseToContinue()
        {
            continueButton.Enabled = true;
            while (!contin)
            {
                Thread.Sleep(100);
            }
            contin = false;
            continueButton.Enabled = false;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            //получаем параметры игры и вносим в переменные
            int maxRate = Convert.ToInt32(maxRateBox.Text);
            int minRate = Convert.ToInt32(minRateBox.Text);
            int money = Convert.ToInt32(startMoneyBox.Text);
            int countDeck = Convert.ToInt32(countDeckBox.Text);
            //отображаем количество денег
            moneyLabel.Text = Convert.ToString(money);
            //масив для хранение колоды, а также переменные для хранения номера следущей карты и общего количества карт
            int[] cardsStack = new int[countDeck*52];
            int nextCard = 0;
            int countCards = 0;
            //проверяем достаточно ли денег для минимальной ставки
            while (money >= minRate)
            {
                //если в колоде осталось мало карт( в даном случае 10*количество колод) выполняем перетасовку колоды
                //обычно значение от 1/3 до 1/5 всех карт, в будущем можно сделать как параметр
                if (countDeck * 10 > countCards)
                {
                    countCards = generationCardsStack(cardsStack, countDeck);
                    countCardsLabel.Text = Convert.ToString(countCards);
                    nextCard = 0;
                }
                //запрос сделать ставку и проверка ставки на возможность (хватает ли денег, и попадает ли в указаные границы)
                statusBox.Text = "Сделайте ставку";
                int rate = 0;
                do
                {
                    rateBox.ReadOnly = false;

                    pauseToContinue();
                    rate = Convert.ToInt32(rateBox.Text);
                    rateBox.ReadOnly = true;
                } while (rate > maxRate | rate < minRate | rate > money);
                //вычитаем с денег ставку и обновляем значение
                money -= rate;
                moneyLabel.Text = Convert.ToString(money);
                //создаем масивы для карт дилера и игрока и обнуляем их
                int[] cardsUser = new int[11];
                for (int i = 0; i < 11; i++) cardsUser[i] = 0;
                int[] cardsDiler = new int[11];
                for (int i = 0; i < 11; i++) cardsDiler[i] = 0;
                //роздаем 1 карту дилеру и 2 игроку
                cardsDiler[0] = cardsStack[nextCard];
                nextCard++;
                countCards--;
                cardsDilerBox.Text = cardToString(cardsDiler);
                pointsDilerBox.Text = Convert.ToString(countRate(cardsDiler));

                cardsUser[0] = cardsStack[nextCard];
                nextCard++;
                countCards--;
                cardsUser[1] = cardsStack[nextCard];
                nextCard++;
                countCards--;
                countCardsLabel.Text = Convert.ToString(countCards);

                cardsUserBox.Text = cardToString(cardsUser);
                pointsUserBox.Text = Convert.ToString(countRate(cardsUser));
                int nextCardUser = 2;
                //цикл добора карт игроком, выполняется до паса или выпадения БлекДжека
                while (!alternative & (countRate(cardsUser) < 21))
                {

                    statusBox.Text = "Взять карту?";
                    continueButton.Enabled = true;
                    pasButton.Enabled = true;
                    //ожидание нажатия паса или продолжить
                    while (!contin & !alternative)
                    {
                        Thread.Sleep(100);
                    }
                    continueButton.Enabled = false;
                    pasButton.Enabled = false;
                    //если нажато "продолжить" выдает карту игроку а также вносит изменнения в соотвествующие поля
                    if (contin)
                    {
                        cardsUser[nextCardUser] = cardsStack[nextCard];
                        nextCard++;
                        nextCardUser++;
                        countCards--;
                        countCardsLabel.Text = Convert.ToString(countCards);

                        cardsUserBox.Text = cardToString(cardsUser);
                        pointsUserBox.Text = Convert.ToString(countRate(cardsUser));
                    }
                    contin = false;
                }
                alternative = false;
                int nextCardDiler = 2;
                //добор карт дилером, по правилам игры пока не будет 17 или более
                while (countRate(cardsDiler) < 17)
                {
                    cardsDiler[nextCardDiler] = cardsStack[nextCard];
                    nextCard++;
                    nextCardDiler++;
                    countCards--;
                    countCardsLabel.Text = Convert.ToString(countCards);
                    cardsDilerBox.Text = cardToString(cardsDiler);
                    pointsDilerBox.Text = Convert.ToString(countRate(cardsDiler));
                    statusBox.Text = "Дилер взял карту";
                    pauseToContinue();
                }

                int rateDiler = countRate(cardsDiler);
                int rateUser = countRate(cardsUser);
                //проверяем на ничью
                if (rateUser == rateDiler)
                {
                    statusBox.Text = "Ничья";
                    money += rate;
                    moneyLabel.Text = Convert.ToString(money);
                }
                //проверяем на победу блекджеком
                else if (rateUser == 21)
                {
                    statusBox.Text = "БлекДжек - победа";
                    money += rate * 3;
                    moneyLabel.Text = Convert.ToString(money);
                }
                //проверяем на обычною победу
                else if ((rateUser > rateDiler)&(rateUser < 21))
                {
                    statusBox.Text = "Победа";
                    money += rate * 2;
                    moneyLabel.Text = Convert.ToString(money);
                }
                //иначе обявляем поражение
                else
                {
                    statusBox.Text = "Поражение";
                }
                pauseToContinue();
                //очищаем поля
                cardsDilerBox.Text = "";
                pointsDilerBox.Text = "";
                cardsUserBox.Text = "";
                pointsUserBox.Text = "";
                rateBox.Text = "";

            }
            //розблокируем доступ к новой игре
            maxRateBox.ReadOnly = false;
            minRateBox.ReadOnly = false;
            startMoneyBox.ReadOnly = false;
            countDeckBox.ReadOnly = false;
            startButton.Enabled = true;
            statusBox.Text = "Нет денег, начни с начала";
        }

        private void continueBox_Click(object sender, EventArgs e)
        {
            contin = true;
        }

        private void pasButton_Click(object sender, EventArgs e)
        {
            alternative = true;
        }
    }
}
