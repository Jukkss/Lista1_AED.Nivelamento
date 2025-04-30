## 📘 Lista 1 – Nivelamento

### Observações:
- Cópias serão desconsideradas, ou seja, a nota será igual a 0 (zero).  
- Implemente os programas utilizando a linguagem C#.

---

### Questões:

**1)** Faça um programa que leia uma sequência de números inteiros positivos, até que seja informado o valor `-1`. Este programa deve imprimir qual é o tamanho da maior sequência crescente recebida.

- **Exemplo:**  
  Entrada: 12, 4, 8, 15, 16, 23, 42, 9, 11, 7, 5, 77, 95, -1  
  Saída esperada: `6`

---

**2)** Faça um programa que leia um número inteiro positivo **N** e imprima as **N** primeiras linhas do **Triângulo de Floyd**.


---

**3)** Leia dois vetores de inteiros **x** e **y**, cada um com **N** elementos. O valor de **N** deve ser lido do teclado. Os vetores não conterão elementos repetidos. Calcule e mostre:

- Soma entre x e y  
- Produto entre x e y  
- Diferença entre x e y (elementos de x que não existem em y)  
- Interseção entre x e y  
- União entre x e y

---

**4)** Faça um programa que apure o resultado de uma votação para determinar o representante da turma do 1º período do curso de Sistemas de Informação.

- Solicitar quantidade de candidatos  
- Ler os nomes dos candidatos (o primeiro terá o número 0, o segundo o número 1, e assim por diante)  
- Ler os votos de **60 alunos** (número do candidato)  
- Apresentar:
- Nome e quantidade de votos do **candidato mais votado**  
- Número e quantidade de votos do **candidato menos votado**  
- Quantidade de **votos nulos** (número inválido)

---

**5)** Crie um programa com as seguintes classes:

#### Classe `Jogador`
- Atributos:
- numero  
- nome  
- posicao (goleiro, zagueiro, lateral, meia, atacante)
- Métodos:
- Construtor  
- Propriedades

#### Classe `Time`
- Atributos:
- nome  
- titulares (vetor de `Jogador`, tamanho 11)  
- reservas (vetor de `Jogador`, tamanho 12)  
- quantTitulares  
- quantReservas  
- Métodos:
- Construtor: inicializa vetores e define `quantTitulares` e `quantReservas` como zero  
- AdicionarTitular  
- AdicionarReserva  
- SubstituirTitular  
- SubstituirReserva  
- ConsultarTitular  
- ConsultarReserva  
- ExcluirTitular  
- ExcluirReserva  
- GerarArqTime (salva todos os jogadores em arquivo texto)

#### Classe `Teste`
- No método `Main`, instancie um time e utilize todos os métodos da classe `Time`.

---

**6)** Implemente um sistema para controle de sua biblioteca pessoal com as classes `Livro` e `Biblioteca`.

#### Classe `Livro`
- Atributos privados:
- titulo  
- autores  
- editora  
- Métodos:
- Construtor  
- Propriedades

#### Classe `Biblioteca`
- Atributos:
- acervo (array de livros)  
- numLivros  
- MAXLIV = 50  
- Métodos:
- Adicionar livro (por parâmetros ou por objeto `Livro`)  
- Retornar livro pelo título  
- Listar todos os títulos  
- Retornar número de livros

#### Classe `Teste`
- Criar um objeto `Biblioteca`  
- Adicionar 4 livros  
- Buscar e imprimir dados de um livro por título  
- Imprimir todos os livros

---

**7)** Implemente a classe `Estacionamento`:

#### Atributos privados:
- nome  
- numVagasLivres  
- vagas (array de string)

#### Métodos:
- `Estacionamento(string nome, int numTotalVagas)`  
- Inicializa nome, vagas e define `numVagasLivres`  
- `int Estacionar(string placa)`  
- Retorna número da vaga ou `-1` se não houver vagas  
- `int BuscarNumVaga(string placa)`  
- Retorna número da vaga da placa ou `-1`  
- `void Retirar(string placa)`  
- Remove o veículo e marca a vaga como vazia  
- Propriedade `NumVagasLivres` (apenas `get`)  
- `void ExibirOcupacao()`  
- Imprime a ocupação de todas as vagas

#### Classe `Teste`:
- Criar estacionamento com 30 vagas  
- Estacionar 5 carros  
- Exibir ocupação  
- Pesquisar uma placa  
- Retirar um carro  
- Exibir ocupação  
- Estacionar mais 3 carros  
- Exibir ocupação  
- Exibir quantidade de vagas livres
