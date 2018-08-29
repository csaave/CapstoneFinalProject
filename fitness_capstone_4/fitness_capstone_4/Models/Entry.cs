using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fitness_capstone_4.Models
{
   
    public class Entry
    {
        

        public int Id { get; set; }


        public DateTime Date { get; set; }


        [Display(Name = "Workout")]
        public int ActivityId { get; set; }


        public Workouts Workouts { get; set; }


        public double Duration { get; set; }


        //public IntensityLevel Intensity { get; set; }


        public bool Exclude { get; set; }


        [MaxLength(200, ErrorMessage = "The notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }

        
    }
}