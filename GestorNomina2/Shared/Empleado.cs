namespace GestorNomina2.Shared
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double? SalarioBase { get; set; }
		public double? Salud()
		{
			return SalarioBase * 0.04;
		}
		public double? Pension()
		{
			return SalarioBase * 0.04;
		}

		public double? NetoAPagar()
		{
			return SalarioBase - Salud() - Pension();
		}



	}
}
