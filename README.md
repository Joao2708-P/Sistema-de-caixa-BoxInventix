# 🧾 Sistema de Caixa (PDV)

Sistema de Caixa (PDV) desenvolvido em **C# WinForms**, focado em controle de vendas, produtos por unidade e peso, descontos, operadores e fluxo real de loja.

Projeto construído com separação clara de responsabilidades (Tela, Service, Repository e Models), seguindo boas práticas para facilitar manutenção e evolução.

---

## 🚀 Funcionalidades

### Caixa (PDV)

* Leitura de **EAN-13**
* Produtos por:

  * Unidade
  * Peso (balança)
* Abertura automática de venda na primeira inserção
* Agrupamento inteligente de itens por unidade
* Itens por peso **não são agrupados**
* Cálculo de:

  * Subtotal
  * Total
  * Descontos
* Cancelamento de itens direto no grid
* Finalização de venda com forma de pagamento

---

### Descontos

* Cadastro de descontos por loja
* Código promocional
* Validade
* Valor percentual
* Listagem em DataGridView
* Pesquisa dinâmica
* Exclusão via botão no grid

---

## 🧱 Arquitetura

O projeto segue uma arquitetura simples e organizada:

```
SistemaDeCaixa
│
├── Models        → Entidades e DTOs
├── Services      → Regras de negócio e cálculos
├── Repository    → Acesso a dados (SQL)
├── Telas         → Forms (UI)
└── Helpers       → Utilidades e filtros
```

### Princípios adotados

* ❌ Nenhuma regra de negócio na UI
* ✅ Cálculos centralizados em `Services`
* ✅ Persistência isolada em `Repository`
* ✅ Models simples (sem lógica)

---

## 🛒 Fluxo de Venda

1. Operador abre o Caixa
2. Digita ou escaneia o código EAN
3. Sistema:

   * Valida EAN-13
   * Identifica produto por peso ou unidade
   * Abre venda automaticamente se necessário
4. Itens aparecem no grid
5. Operador pode remover itens
6. Finaliza a venda e escolhe forma de pagamento

---

## 📦 ItemCaixa (Snapshot)

Durante a venda, cada item guarda um **snapshot**, garantindo integridade histórica:

* Produto
* Quantidade ou Peso
* Preço unitário no momento da venda
* Desconto aplicado

Nenhum cálculo fica dentro do `ItemCaixa`.

---

## 🧮 Cálculos

Todos os cálculos são feitos pelo:

```
CaixaService
```

* Subtotal
* Total
* Descontos
* Projeção para Grid

Isso garante:

* Consistência
* Facilidade de teste
* Manutenção simples

---

## 🖥️ Interface (WinForms)

* DataGridView com:

  * Botão de cancelar item
  * Checkbox de seleção
* Atualização de grid desacoplada
* Feedback claro ao usuário

---

## 🔐 Sessão

O sistema utiliza sessão para:

* Loja ativa
* Funcionário logado

Exemplo:

```csharp
Sessao.LojaId
Sessao.UsuarioLogado
```

---

## 🗑️ Exclusão de Descontos

* Seleção via checkbox
* Botão Delete no grid
* Confirmação antes da exclusão
* Exclusão direta no banco via Repository

---

## 🛠️ Tecnologias

* C#
* WinForms
* ADO.NET
* SQL Server

---

## 🧠 Próximos Passos (Roadmap)

* [ ] TEF (integração bancária)
* [ ] Pagamento múltiplo
* [ ] Soft Delete
* [ ] Auditoria de vendas
* [ ] Relatórios

---

## ✅ Status do Projeto

✔ Caixa funcional
✔ Descontos funcionais
✔ Estrutura sólida
✔ Pronto para expansão

---

## 👊 Autor
João Guilherme Pereira dos Santos

Projeto desenvolvido com foco em **sistema real de loja**, priorizando clareza, controle e escalabilidade.

> "Uma coisa de cada vez — mas feita do jeito certo." 🔥
