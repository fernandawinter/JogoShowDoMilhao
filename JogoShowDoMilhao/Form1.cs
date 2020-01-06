using JogoShowDoMilhao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoShowDoMilhao
{
    public partial class Form1 : Form
    {
        List<Question> availableQuestions = new List<Question>();

        Question randomQuestion;

        public Form1()
        {
            InitializeComponent();

            availableQuestions.Add(new Question()
            {
                QuestionDescription = "Onde fica a cidade de Feira de Santana?",
                Option1 = "Pernambuco",
                Option2 = "Bahia",
                Option3 = "Sergipe",
                Option4 = "Alagoas",
                CorrectAnswer = 2,
                DifficultyLevel = "Fácil"
            });

            availableQuestions.Add(new Question()
            {
                QuestionDescription = "O falcão é ...",
                Option1 = "Réptil",
                Option2 = "Ave",
                Option3 = "Anfíbio",
                Option4 = "Mamífero",
                CorrectAnswer = 2,
                DifficultyLevel = "Fácil"
            });

            availableQuestions.Add(new Question()
            {
                QuestionDescription = "Trompa de falópio é ...",
                Option1 = "Pequeno trombone",
                Option2 = "Esforço de guerra",
                Option3 = "Barulho ensurdecedor",
                Option4 = "Órgão feminino",
                CorrectAnswer = 4,
                DifficultyLevel = "Fácil"
            });

            Random rnd = new Random();
            int r = rnd.Next(availableQuestions.Count);
     
            randomQuestion = availableQuestions[r];

            lblQuestionDescription.Text = randomQuestion.QuestionDescription;
            rdbOption1.Text = randomQuestion.Option1;
            rdbOption2.Text = randomQuestion.Option2;
            rdbOption3.Text = randomQuestion.Option3;
            rdbOption4.Text = randomQuestion.Option4;
        }

        int userAnswer = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (userAnswer == randomQuestion.CorrectAnswer)
            {
                MessageBox.Show("Certa resposta!");

                Random rnd = new Random();
                int r = rnd.Next(availableQuestions.Count);

                randomQuestion = availableQuestions[r];

                lblQuestionDescription.Text = randomQuestion.QuestionDescription;
                rdbOption1.Text = randomQuestion.Option1;
                rdbOption2.Text = randomQuestion.Option2;
                rdbOption3.Text = randomQuestion.Option3;
                rdbOption4.Text = randomQuestion.Option4;
            }
            else
            {
                MessageBox.Show("Que pena! Resposta errada!");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer = 4;
        }
    }
}
