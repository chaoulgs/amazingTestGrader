using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingPractice
{
    public class Answer
    {
        public Answer()
        {
            IsCorrect = false;
            Credit = 0;
        }

        public Answer(string content,int questionNumber)
        {
            Content = content;
            IsCorrect = false;
            QuestionNumber = questionNumber;
            Credit = 0;
        }

        public Answer(string content, bool isCorrect)
        {
            Content = content;
            IsCorrect = isCorrect;
            if (isCorrect)
            {
                Credit = 1;
            }
        }

        public int QuestionNumber { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public double Credit { get; set; }
    }
}
