﻿using Ecommerce.Entities.Entity.Abstruction;
using Ecommerce.Entities.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Entity.Concrete
{
    public class BaseEntity : IKernelEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get ; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate 
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status 
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
