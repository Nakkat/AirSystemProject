using System;
using System.Collections.Generic;
using System.Linq;

public class UsuarioRepository
{
        // Lista que irá armazenar os dados do usuário para carregar no DataGridView
        // A declaração static fará a criação na memória - se ela já existir ele não cria novamente

    private static List<Usuario> usuarios;
    // Contador - id do usuário
    private static int contador = 1;

    // Contrutor do repositório
    public UsuarioRepository()
    {
        // Se a lista estiver vazia - cria uma instacia da lista
        if (usuarios == null)
        {
            usuarios = new List<Usuario>();


            // Dados previamente adicionados na lista para facilitar teste do editar e excluir
            usuarios.Add(new Usuario
            {
                ID = 1,
                nome = "Bruno",
                sobrenome = "Nakamura",
                dataNascimento = Convert.ToDateTime("15/05/2002"),
                endereco = "Tijuco Preto",
                numero = "255",
                usuario = "adm",
                senha = "adm",
                tipoUsuario = true
            }
           );
            contador++;
            usuarios.Add(new Usuario
            {
                ID = 2,
                nome = "Fernanda",
                sobrenome = "Isola",
                dataNascimento = Convert.ToDateTime("03/04/2001"),
                endereco = "Tijuco Preto",
                numero = "255",
                usuario = "comum",
                senha = "comum",
                tipoUsuario = false
            }
            );
            contador++;
        }
    }
    // Criar método para retornar todos os usuários
    public List<Usuario> buscarTodos()
    {
        return usuarios;
    }

    public Usuario BuscarPorId(int id)
    {
        return usuarios.FirstOrDefault(u => u.ID == id);
    }
    public void Deletar(int id)
    {
        Usuario u = BuscarPorId(id);
        usuarios.Remove(u);
    }

    public Usuario login (string username, string pass)
    {
        return usuarios.Find(u => u.usuario == username && u.senha == pass);
    }
    // Método que irá adicionar usuários
    public void adicionar(Usuario usuario)
    {
        usuario.ID = contador;

        usuarios.Add(usuario);
        contador++;
    }
    //  Altera os dados da lista
    public void editar(Usuario usuario)
    {
        // Pega a posição do objeto dentro da lista
        // Funcao lambda para pegar o índice do item que será alterado
        // Lambda é uma ação anonima para aplicar uma regra

        // pegar a posição o objeto dentro da lista
        Usuario u = usuarios.Find(x => x.ID == usuario.ID);
        usuarios[usuarios.IndexOf(u)] = usuario;
    }
}

	
