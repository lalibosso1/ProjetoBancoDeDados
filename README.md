# Projeto Banco de Dados 💾

Este projeto é um sistema desktop desenvolvido em C# com Windows Forms, voltado para fins educacionais e didáticos. O sistema possui autenticação de usuário e uma interface principal com funcionalidades integradas — ideal para introdução ao desenvolvimento com acesso a banco de dados e uso de formulários estruturados.

## 🔐 Funcionalidades

- Login com validação de usuário
- Interface principal após autenticação
- Estrutura organizada por camadas (View, possivelmente Model/Controller)
- Pronto para integração com banco de dados

## 🛠 Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET Framework
- **Interface gráfica:** Windows Forms
- **IDE:** Visual Studio
- **Organização:** Arquitetura baseada em camadas (indicativo de padrão MVC ou similar)

## 🗃 Integração com Banco de Dados

Este sistema já conta com um banco de dados integrado ao projeto, pronto para uso com:

- Conexão local com arquivo de banco 
- Operações de autenticação e acesso de dados via Windows Forms
- Possibilidade de extensão para operações CRUD

### Como configurar

1. Certifique-se de ter o **SQL Server** instalado.
2. Verifique a string de conexão no arquivo `App.config` e ajuste conforme o caminho do banco em sua máquina.
3. Rode o projeto normalmente e o sistema fará a conexão automaticamente ao iniciar.

> 💡 Se quiser saber exatamente como a conexão está configurada, veja o conteúdo do `App.config`.

