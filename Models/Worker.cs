namespace FutureOfWork.Api.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MainSkill { get; set; } = string.Empty;
        
        // Remoto / Híbrido / Presencial
        public string PreferredWorkMode { get; set; } = string.Empty;

        public int YearsOfExperience { get; set; }

        // Relacionamento opcional com Jobs
        public ICollection<Job>? Jobs { get; set; }
    }
}
