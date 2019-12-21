using Job.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Entities.Entities
{
    [Table("MUSTERI")]
    public partial class MUSTERI : IEntity
    {
        [Key]
        public int SIRANO { get; set; }
        public string CARIKODU { get; set; }
        [DisplayName("COMPANY NAME")]
        public string KISAUNVAN { get; set; }
        [DisplayName("CITY")]
        public string SEHIR { get; set; }
        [DisplayName("COUNTRY")]
        public string ULKE { get; set; }
        [DisplayName("ADDRESS")]
        public string TESLIM { get; set; }
        public string WEB { get; set; }
        [DisplayName("E-MAIL")]
        public string WEBMAIL { get; set; }
        public string TEL1 { get; set; }
        public string FAKS { get; set; }
        [DisplayName("PASSWORD"), DataType(DataType.Password)]
        public string WEBSIFRE { get; set; }
        [DisplayName("TAX NUMBER")]
        public string VERGINO { get; set; }
        [DisplayName("TAX OFFICE")]
        public string VERGIDAIRESI { get; set; }
        public string YETKILI { get; set; }
        public string EYALET { get; set; }
        public string ILCE { get; set; }
        public string KATAGORI { get; set; }
        public string DOVIZ { get; set; }
        public string CARIGOSTER { get; set; }
        public string CARIPERSONEL { get; set; }
        public string CARIPERSONELKISAUNVAN { get; set; }
        public string B2BACIK { get; set; }
    }
}
