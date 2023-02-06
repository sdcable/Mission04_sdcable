using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_sdcable.Models
{
    //Models for each of the grade calculator. Required and Range on each of them.
    public class FormModel
    {
        [Range(0, 100)]
        [Required]
        public int Assignments { get; set; }

        [Range (0,100)]
        [Required]
        public int GroupProject { get; set; }

        [Range(0, 100)]
        [Required]
        public int Quizzes { get; set; }

        [Range(0, 100)]
        [Required]
        public int MidtermExam { get; set; }

        [Range(0, 100)]
        [Required]
        public int FinalExam { get; set; }

        [Range(0, 100)]
        [Required]
        public int GroupINTEX { get; set; }
    }
}
