namespace Fekete_László_Backend_20240229.Models.Dtos
{
    //JegyekDtos
    public record JegyekDto(int id, int jegy_szammal, string jegy_szoveggel, DateTime beiras_datuma, DateTime modositas_datuma, Tanarok IdTanarokNavigation, Tantargyak IdTantargyakNavigation);
    public record CreateJegyekDto(int jegy_szammal, string jegy_szoveggel, DateTime beiras_datuma, DateTime modositas_datuma, Tanarok IdTanarokNavigation, Tantargyak IdTantargyakNavigation);
    public record UpdateJegyekDto(int jegy_szammal, string jegy_szoveggel, DateTime modositas_datuma, Tanarok IdTanarokNavigation, Tantargyak IdTantargyakNavigation);
    //TanarokDtos
    public record TanarokDto(int id, string vezetek_nev, string kereszt_nev, string email, string nem);
    public record CreateTanarokDto(string vezetek_nev, string kereszt_nev, string email, string nem);
    public record UpdateTanarokDto(string vezetek_nev, string kereszt_nev, string email, string nem);
    //TantargyakDtos
    public record TantargyakDto(int id, string tantargy_nev, string tantargy_leiras, ICollection<Jegyek> Jegyeks);

    public record CreateTantargyakDto(string tantargy_nev, string tantargy_leiras);

    public record UpdateTantargyakDto(string tantargy_nev, string tantargy_leiras);
}
