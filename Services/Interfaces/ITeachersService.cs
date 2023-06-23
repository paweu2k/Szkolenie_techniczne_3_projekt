using System.Collections.Generic;
using Szkolenie_techniczne_3_projekt.Models;

namespace Szkolenie_techniczne_3_projekt.Services.Interfaces
{
    public interface ITeachersService
    {
        int Save(Teachers teachers);

        List<Teachers> GetAll();
        Teachers Get(int id);
        int Delete(int id);
    }
}
