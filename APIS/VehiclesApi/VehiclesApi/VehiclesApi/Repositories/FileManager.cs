namespace VehiclesApi.Repositories
{
    public class FileManager
    {
        private static string _currentDirectory = Directory.GetCurrentDirectory();
        private static string _filePath = Path.Combine(_currentDirectory, "vehicles.txt");
        public static void SaveVehicle(string vehicle)
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
            File.AppendAllText(_filePath, vehicle + "," + Environment.NewLine);
        }
        public static string ReadVehicles()
        {
            return "["+File.ReadAllText(_filePath)+"]";
        }
    }
}
