using BreadFinder.API.DAL.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadFinder.API.BLL
{
    public interface IPlaatsDTO
    {
        PlaatsDTO ConvertToPlaatsDTO(Plaats plaats);
        Plaats ConvertToPlaatsENT(PlaatsDTO plaatsDTO);
    }
}
