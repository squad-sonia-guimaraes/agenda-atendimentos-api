namespace AgendaAtendimentos.Models
{
    public class Expediente
    {
        public int Id { get; set; }
        public int ProfissionalId { get; set; }
        public DayOfWeek DiaSemana { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFim { get; set; }

        public Expediente(int id, int profissionalId, DayOfWeek diaSemana, TimeOnly horaInicio, TimeOnly horaFim)
        {
            Id = id;
            ProfissionalId = profissionalId;
            DiaSemana = diaSemana;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
        }
    }
}
