using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TPsema.Models
{
    public partial class Customer
    {
        public string Id { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DisplayName("Даты командировки")]
        public string Date { get; set; }
        [DisplayName("Направление")]
        public string Naprav { get; set; }
        [DisplayName("Суточные (руб.)")]
        public string Sutoch { get; set; }
        [DisplayName("Жилье (руб.)")]
        public string Home { get; set; }
        [DisplayName("Проезд")]
        public string Proezd { get; set; }
        [DisplayName("Сумма командировки (руб.)")]
        public string Summ { get; set; }

    }
}