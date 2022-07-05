using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingSystem
{
    public partial class TestingSystemForm : Form
    {
        //Ответы игрока
        static string[] userAnswers;
        //Колличество правильных ответов
        static int score;
        //Ответ игрока на текущий вопрос(1,2,3,4)
        static string userResponse = "";
        //Номер текущего вопроса
        static int questNumber = 0;
        //Сколько всего вопросов
        static int totalQuestions;
        //Хранит в себе все правильные ответы
        static string correctAnswers;
        //Хранит в себе все вопросы и по 4 варианта ответа на каждый
        static List<Tuple<string, List<string>>> questions = new List<Tuple<string, List<string>>>();
        public TestingSystemForm()
        {
            InitializeComponent();
            GetTestsCollection();
            EndTest();
        }

        //получить перечень тестов.
        public void GetTestsCollection()
        {
            var testNames = Directory.GetFiles(@"..\..\tests"); //получить все файлы из папки tests
            foreach (var testName in testNames) // пройтись по списку файлов
            {
                //очистка всего лишнего
                var temp = testName.Split('\\');
                var name = temp[temp.Length - 1];
                comboBoxTests.Items.Add(name.Substring(0,name.Length-4));//добавление имнеи файла(теста) в
                                                                         //колекцию выплывающего списка
            }   
        }

        //Обрабатываем файлик с вопросами и заполняем лист totalQuestions.
        public void GetAllQuestions()
        {
            string testName = comboBoxTests.Text;
            if (String.IsNullOrEmpty(testName)) //Если поле выплывающеко списка пустое
            {
                MessageBox.Show("Тест не выбран");
                return;
            }
            using (StreamReader sr = new StreamReader($"..\\..\\tests\\{testName}.txt")) //открыть файл testName
            {
                correctAnswers = sr.ReadLine(); //правильные ответы
                totalQuestions = int.Parse(sr.ReadLine());  //количество вопросов
                for (int i = 0; i < totalQuestions; i++)
                {
                    string ques = sr.ReadLine(); //считать вопрос
                    var list = new List<string>();
                    for (int j = 0; j < 4; j++)
                    {
                        string s = sr.ReadLine(); //считать вариант ответа
                        list.Add(s); //добавить в лист вариант ответа
                    }
                    var tup = Tuple.Create(ques, list); //Создать пару вопрос и варианты ответов
                    questions.Add(tup); //добавить пару в лист
                }
            }
        }

        //начало теста.
        public void StartTest()
        {
            nextQuestButton.Enabled = true;
            ClearSelection();
            questNumber = 0;
            score = 0;
            userAnswers = new string[totalQuestions];
            FillInTheAnswerOptions(questNumber);
        }

        //конец теста.
        public void EndTest()
        {
            earlyQuestButton.Enabled = false;
            nextQuestButton.Enabled = false;
        }

        //Изменение лейблов и радиокнопок.
        public void FillInTheAnswerOptions(int questNumber)
        {
            questNumb.Text = "Номер Вопроса:" + (questNumber + 1).ToString();//Изменить лейбл номер вопроса
            question.Text = questions[questNumber].Item1;//Изменить текст вопроса
            var list = questions[questNumber].Item2;//получить лист ответов
            int i = 0;
            foreach (var item in panelAnswers.Controls) // пройтись по всм элементам панели
            {
                var radio = item as RadioButton;//присвоить если это радиокнопка
                if (radio != null) //если это радиокнопка
                {
                    radio.Text = $"{4-i}) {list[i]}";//изменить её текст на вариант ответа
                    if (!String.IsNullOrEmpty(userAnswers[questNumber]) && int.Parse(userAnswers[questNumber]) == 4-i) 
                        //если ответ был и индекс кнопки совподает с ответом
                        radio.Checked = true;//выбрать ответ
                    i++;
                }
            }
        }

        //Запоминает варинат ответа пользователя.
        private void RadioButton_Checked(object sender, EventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            userResponse = pressed.Text.ToString()[0].ToString();//получает индекс радиокнопки
        }

        //Выводит след вопрос на экран.
        private void nextQuestButton_Click(object sender, EventArgs e)
        {
            earlyQuestButton.Enabled = true; //разблокировать кнопку преыдущий вопрос
            userAnswers[questNumber] = userResponse; //запомнить ответ пользователя
            ClearSelection();//очистить выбор
            if (questNumber < totalQuestions - 1)//если это не последний вопрос
            {
                questNumber++;
                FillInTheAnswerOptions(questNumber);//Изменить вопрос и варианты ответов
            }
            else
            {
                calculateScore();//посчитать колличество баллов
                //вывесли окно с итоговым результатом
                MessageBox.Show($"Тест окончен\nВы набрали {score} б.\nЕсли вы желаете начать тест заного нажмите на кнопку \"Перезапуск\"");
                using (StreamWriter sw = new StreamWriter(@"..\..\ListOfPlayers.txt", true))//открыть файл
                {
                    sw.WriteLine($"{playerNickname.Text} набрал {score} б.");//записать результат
                }
                EndTest();//заблокировать кнопкиВ
            }

        }

        //Сбросить всё.
        private void restartButton_Click(object sender, EventArgs e)
        {
            playerNickname.Text = "";
            StartTest();
        }

        //посчитать результат.
        public void calculateScore()
        {
            for (int i = 0; i < totalQuestions; i++)
                if (userAnswers[i] == correctAnswers[i].ToString())
                    score++;
        }

        //очистить выбор.
        public void ClearSelection()
        {
            foreach (var item in panelAnswers.Controls) // пройтись по всм элементам панели
            {
                var radio = item as RadioButton; //присвоить если это радиокнопка
                if (radio != null) //если радиокнопка
                    radio.Checked = false; //снять выбор
            }
            userResponse = "";//очистить ответ пользователя
        }

        //Начать тест.
        private void buttonStart_Click(object sender, EventArgs e)
        {
            GetAllQuestions();         
            StartTest();
        }

        //перейти на предыдущий вопрос.
        private void earlyQuestButton_Click(object sender, EventArgs e)
        {
            userAnswers[questNumber] = userResponse;//сохранить ответ
            if (questNumber > 1)//если
            {
                questNumber--;
                FillInTheAnswerOptions(questNumber);
            }
            else
            {
                earlyQuestButton.Enabled = false; //заблокировать кнопку предыдущий вопрос
            }
        }
    }
}
