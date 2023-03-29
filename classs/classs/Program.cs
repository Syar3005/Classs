using classs;

PlayerStats[] statsArr = new PlayerStats[5];

statsArr[0] = new PlayerStats(10, 3, 7);
statsArr[1] = new PlayerStats(8, 2, 9);
statsArr[2] = new PlayerStats(8, 0, 8);
statsArr[3] = new PlayerStats(6, 4, 10);
statsArr[4] = new PlayerStats(3, 6, 11);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(statsArr[i].ToString());
}