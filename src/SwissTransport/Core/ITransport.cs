namespace SwissTransport.Core
{
    using System.Threading.Tasks;

    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation);
        Connections GetConnections2(string fromStation, string toStation, string departure, string time);
    }

}