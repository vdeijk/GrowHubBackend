namespace Models
{
    public static class AppointmentMockData
    {
        public static List<AppointmentItem> GetAppointments()
        {
            return new List<AppointmentItem>
            {
                new AppointmentItem
                {
                    Time = "09:00 AM",
                    Title = "Meeting with Bob",
                    Description = "Discuss project updates"
                },
                new AppointmentItem
                {
                    Time = "11:00 AM",
                    Title = "Doctor Appointment",
                    Description = "Annual check-up"
                },
                new AppointmentItem
                {
                    Time = "01:00 PM",
                    Title = "Lunch with Sarah",
                    Description = "Catch up over lunch"
                },
                new AppointmentItem
                {
                    Time = "03:00 PM",
                    Title = "Team Standup",
                    Description = "Daily team meeting"
                },
                new AppointmentItem
                {
                    Time = "05:00 PM",
                    Title = "Gym",
                    Description = "Workout session"
                }
            };
        }
    }
}
