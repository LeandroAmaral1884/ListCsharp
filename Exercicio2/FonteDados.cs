using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FonteDados
{

    public static List<Aluno> ListaAlunos(){


        List<Aluno> alunos = new()
        {
          new Aluno {Nome="Pedro",Nota=8.5},
          new Aluno {Nome="José",Nota=9.5},
          new Aluno {Nome="Paulo",Nota=7.5},
          
        };
        
        return alunos;
        }

    }

