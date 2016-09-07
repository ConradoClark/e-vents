using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Model.Base
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
    }
}
