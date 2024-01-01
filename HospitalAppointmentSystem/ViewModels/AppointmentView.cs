﻿using System.ComponentModel.DataAnnotations;

namespace HospitalAppointmentSystem.ViewModels
{  
    public class AppointmentView
    {
        public int doctorId { get; set; }
        public string userId { get; set; }
        public DateTime appointmentDate { get; set; } 
        public int appointmentTime { get; set; } // 0--5
    }
}
