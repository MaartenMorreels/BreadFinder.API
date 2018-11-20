using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.BLL
{
    public class PlaatsDTO : IPlaatsDTO
    {
        public int PlaatsId { get; set; }
        public string PostCode { get; set; }
        public string PlaatsNaam { get; set; }
        public string Provincie { get; set; }

        public PlaatsDTO ConvertToPlaatsDTO(Plaats plaats)
        {
            var plaatsDTO = new PlaatsDTO
            {
                PlaatsId = plaats.Id,
                PostCode = plaats.PostCode,
                PlaatsNaam = plaats.PlaatsNaam,
                Provincie = plaats.Provincie
            };
            return plaatsDTO;
        }


        public Plaats ConvertToPlaatsENT(PlaatsDTO plaatsDTO)
        {
            var plaats = new Plaats
            {
                PostCode = plaatsDTO.PostCode,
                PlaatsNaam = plaatsDTO.PlaatsNaam,
                Provincie = plaatsDTO.Provincie
            };
            return plaats;
        }
    }
}