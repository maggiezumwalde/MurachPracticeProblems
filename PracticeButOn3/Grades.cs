﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    class Grades {

        public int numericalGrade { get; set; }
        public string letterGrade { get; set; }



        public void SetNumber(int numericalGrade) {
                this.numericalGrade = numericalGrade;
        }

        public int GetNumber() {           
            return numericalGrade;
        }

        public string GetLetter(int numericalGrade) {
            if (this.numericalGrade > 88 && this.numericalGrade < 100) {
                letterGrade = "A";
            }
            if (this.numericalGrade > 80 && this.numericalGrade < 87) {
                letterGrade = "B";
            }
            if (this.numericalGrade > 67 && this.numericalGrade < 79) {
                letterGrade = "C";
            }
            if (this.numericalGrade > 60 && this.numericalGrade < 67) {
                letterGrade = "D";
            }
            if (numericalGrade < 60) {
                letterGrade = "F";
            }
            return letterGrade;
        }

        public Grades() {
            
        }

        public Grades(int numericalGrade) {
            this.numericalGrade = numericalGrade;
        
        }
    }
}
