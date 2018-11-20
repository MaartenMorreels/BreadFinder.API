using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.BLL
{
    public interface IAutomaatDTO
    {
        Automaat ConvertToEnt(AutomaatDTO automaatDTO);
        AutomaatDTO ConvertToDTO(Automaat automaat);
    }
}
