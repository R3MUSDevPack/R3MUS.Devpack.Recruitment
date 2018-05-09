﻿using R3MUS.Devpack.Recruitment.Enums;
using System;

namespace R3MUS.Devpack.Recruitment.Repositories.Entities
{
    public class History
    {
        public int Id { get; set; }
        public long RecruitId { get; set; }
        public int StatusInt { get; set; }
        public DateTime ActionDate { get; set; }
        public ApplicationStatus Status
        {
            get
            {
                return (ApplicationStatus)StatusInt;
            }
            set
            {
                StatusInt = (int)value;
            }
        }
        public virtual Recruit Recruit { get; set; }
    }
}