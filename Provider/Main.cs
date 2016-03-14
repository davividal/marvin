/**
 * Com o cliente e servidor da última aula, implementar:
 * 	Estabelecer conexão com vários clientes
 * 	Escrever um código de teste para simular a troca de mensagens ininterruptas 
 * 	(envio de arquivos ~10MB)
 * 	Visualização no servidor sobre informações referentes a conexão de cada cliente (ativo, andamento do download)
 * 	Log de tempo das transações
 **/

using System;

namespace Provider
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Server Server = new Server(4200);
		}
	}
}
