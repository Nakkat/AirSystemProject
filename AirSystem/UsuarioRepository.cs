﻿using System;

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
                Nome = "Erik",
                Sobrenome = "Vitelli"
            }
           );
            contador++;
            usuarios.Add(new Usuario
            {
                ID = 2,
                nome = "Bruno",
                Sobrenome = "Nakamura"
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
        Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
        usuarios[usuarios.IndexOf(u)] = usuario;
    }

    // Remove dados da lista
    public void deletar(int codigo)
    {
        // Recupero o usuário atraves do código
        Usuario usuario = usuarios.Find(x => x.ID == ID);

        // Removo o usuário da lista;
        usuarios.Remove(usuario);
    }
}

	
