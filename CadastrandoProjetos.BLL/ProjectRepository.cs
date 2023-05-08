using CadastrandoProjetos.MODEL;

namespace CadastrandoProjetos.BLL
{
    public static class ProjectRepository
    {
        public static void Add(Projeto _projeto)
        {
            using (var dbContext = new CUsersEnzogSourceReposCadastrandoprojetosCadastrandoprojetosDalDatabaseDatabase1MdfContext())
            {
                dbContext.Add(_projeto);
                dbContext.SaveChanges();
            }
        }

        public static Projeto GetById(int Id)
        {
            using (var dbContext = new CUsersEnzogSourceReposCadastrandoprojetosCadastrandoprojetosDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == Id);
                return projeto;
            }
        }

        public static List<Projeto> GetAll()
        {
            using (var dbContext = new CUsersEnzogSourceReposCadastrandoprojetosCadastrandoprojetosDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.ToList();
                return projeto;
            }
        }

        public static void Update(Projeto _projeto)
        {
            using (var dbContext = new CUsersEnzogSourceReposCadastrandoprojetosCadastrandoprojetosDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == _projeto.Id);
                projeto.Nome = _projeto.Nome;
                projeto.Status = _projeto.Status;
                projeto.Gerente = _projeto.Gerente;
                projeto.Resumo = _projeto.Resumo;
                projeto.DataFinal = _projeto.DataFinal;
                dbContext.SaveChanges();
            }
        }

        public static void Excluir(Projeto _projeto)
        {
            using (var dbContext = new CUsersEnzogSourceReposCadastrandoprojetosCadastrandoprojetosDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == _projeto.Id);
                dbContext.Remove(projeto);
                dbContext.SaveChanges();
            }
        }

        public static Projeto GetByNome(String nome)
        {
            using (var dbContext = new CUsersEnzogSourceReposCadastrandoprojetosCadastrandoprojetosDalDatabaseDatabase1MdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Nome == nome);
                return projeto;
            }
        }
    }
}