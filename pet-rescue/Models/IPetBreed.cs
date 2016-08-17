using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_rescue.Models
{
    interface IPetBreed<T>
    {
        T Breed { get; set; }
    }
}
