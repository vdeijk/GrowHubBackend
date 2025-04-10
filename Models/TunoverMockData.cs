namespace Models
{
    public static class TurnoverMockData
    {
        public static List<TurnoverItem> GetTurnovers()
        {
            return new List<TurnoverItem>
            {
                new TurnoverItem { Date = "10-01", Amount = 1500 },
                new TurnoverItem { Date = "18-01", Amount = 2000 },
                new TurnoverItem { Date = "25-01", Amount = 2200 },
                new TurnoverItem { Date = "01-02", Amount = 2000 },
                new TurnoverItem { Date = "08-02", Amount = 2600 },
                new TurnoverItem { Date = "15-02", Amount = 2500 },
                new TurnoverItem { Date = "22-02", Amount = 2800 },
                new TurnoverItem { Date = "1-03", Amount = 2600 },
                new TurnoverItem { Date = "08-03", Amount = 3200 },
                new TurnoverItem { Date = "15-03", Amount = 4000 },
                new TurnoverItem { Date = "22-03", Amount = 4400 },
                new TurnoverItem { Date = "29-03", Amount = 4400 }
            };
        }
    }
}

