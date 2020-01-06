﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoShowDoMilhao.Model
{
    public class Question
    {
        public string QuestionDescription { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public int CorrectAnswer { get; set; }
        public string DifficultyLevel { get; set; }
    }
}
