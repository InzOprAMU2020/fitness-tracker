﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models
{

    public class ExerciseHistory
    {

        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public virtual Exercise Exercise { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public virtual ICollection<ExerciseHistoryStats> ExerciseHistoryStats { get; set; }

    }

}
