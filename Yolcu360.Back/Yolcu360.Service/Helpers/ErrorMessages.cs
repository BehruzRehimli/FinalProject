using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Helpers
{
    public static class ErrorMessages
    {
        public static string NameTaken(string name)
        {
            return $"Name- {name} is already taken!";
        }
        public static string NotFoundId(int? id,string entityName)
        {
            return $"There is no {entityName} with {id} id!";
        }
        public static string NoDelete(string deleteOne,string objects)
        {
            return $"You can't delete this {deleteOne}.First you must delete relational {objects}!";
        }
        public static string ImageFileType()
        {
            return "Image file must be 'jpeg' or 'png'!";
        }
        public static string ImageFileSize()
        {
            return "Image file can't be greater than 5 Mbayt!";
        }
    }
}
