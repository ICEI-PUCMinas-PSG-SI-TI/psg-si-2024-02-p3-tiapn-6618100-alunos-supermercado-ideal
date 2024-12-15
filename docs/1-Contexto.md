## 1. Introdução
O presente trabalho aborda o desenvolvimento de um sistema para supermercados, focado na automação e otimização de atividades essenciais, como controle de estoque, gestão de compras, atendimento de caixa e gerenciamento de filas no setor de açougue. Segundo pesquisas da Associação Brasileira de Supermercados (ABRAS), o setor supermercadista em 2023 obteve R$ 1.001,3 trilhão em faturamento, este resultado representa 9,02% do Produto Interno Bruto (PIB) nacional, o que torna a implementação de soluções tecnológicas fundamentais para a competitividade.
Este projeto, poderá ser útil para reduzir erros humanos, otimizar processos e aumentar a lucratividade. Nesse sentido, sistemas que automatizam o controle de estoque e agilizam o atendimento ao cliente, tem papel fundamental para melhorar a experiência do cliente.
O problema que o projeto visa resolver é a falta de eficiência em algumas operações essenciais dentro de um supermercado, como o monitoramento do estoque, a gestão das compras e o atendimento ao cliente nos caixas. Muitas vezes, esses processos são realizados de forma manual ou com sistemas desatualizados, o que resulta em falhas como falta de produtos, filas longas e insatisfação do consumidor. A motivação para este projeto está na oportunidade de desenvolver uma solução tecnológica que possa oferecer mais controle, economia e eficiência para os supermercados, melhorando tanto a gestão interna quanto a experiência do cliente.
O grupo escolheu este tema por entender a relevância do contexto de negócio dos supermercados no cenário atual e o impacto positivo que a automação de processos pode gerar nesse setor. A partir de pesquisas e análises de sistemas já existentes, a equipe buscará desenvolver uma plataforma funcional, que atenda às necessidades operacionais de um supermercado, especialmente nas áreas de estoque, compras e atendimento.

## 1.1. Objetivos geral e específicos
O objetivo do trabalho é identificar e modelar os principais processos de negócios de um supermercado. Os negócios que serão citados serão controle de compras, no qual será destacado o monitoramento das compras feitas pelo supermercado dos produtos que serão vendidos no mesmo. Além disso, será mencionada a inspeção do estoque, onde será controlado a quantidade de itens que estarão no estoque do supermercado para venda. Também será destacado o processo do caixa, no qual os produtos, a quantidade e os preços serão registrados e somados num preço total. E por fim, o pagamento que é sub processo do atendimento do caixa. Este processo será o responsável pela gestão das formas de pagamento.

## 1.2. Justificativas
O Supermercado Ideal, sendo um estabelecimento de pequeno porte, enfrenta o desafio de se destacar em um mercado altamente competitivo, onde grandes redes de supermercados dominam. A implementação de um sistema que gerencie os principais processos de negócios é essencial para melhorar a eficiência operacional e proporcionar um atendimento de qualidade, fatores que podem diferenciar o Supermercado Ideal da concorrência.
Com a modelagem dos processos de controle de compras, inspeção de estoque e operações de caixa, o supermercado pode otimizar suas atividades, evitando desperdícios, prevenindo rupturas de estoque e garantindo uma experiência de compra mais ágil e eficiente para seus clientes. A automatização e o controle desses processos são especialmente importantes em um pequeno supermercado, onde o impacto de erros, como falhas no registro de produtos ou no controle de estoque, pode ser ainda mais significativo em termos de prejuízos financeiros.


## Stakeholders

**Gerente de Supermercado**
Perfil: Profissional responsável pela gestão geral da loja, incluindo todas as operações do supermercado.
Funções: Acompanhamento e controle de estoque para evitar rupturas ou excessos.
Aprovação de compras de novos produtos junto aos fornecedores.
Análise de relatórios de desempenho, como vendas e movimentação de produtos.

**Funcionário do Estoque**
Perfil: Profissional responsável pela entrada, organização e movimentação de mercadorias no depósito do supermercado.
Funções: Recebimento e conferência de mercadorias, comparando o que foi entregue com o pedido de compra.
Registro de entrada de produtos no sistema de controle de estoque.
Geração de relatórios de produtos em baixa no estoque para solicitação de reposição.

**Operador de Caixa**
Perfil: Responsável pelo atendimento direto ao cliente no momento da finalização da compra.
Funções: Registro das compras dos clientes no sistema.
Emissão de cupons fiscais e notas fiscais eletrônicas.
Gestão de troco e finalização de pagamentos, que podem incluir dinheiro, cartões ou outros meios de pagamento.

**Equipe de Compras**
Perfil: Profissionais encarregados de gerenciar a aquisição de mercadorias para manter o abastecimento do supermercado.
Funções: Definição de fornecedores e negociação de preços e prazos de entrega.
Geração e acompanhamento de pedidos de compra, utilizando informações de necessidade de estoque.
Análise do histórico de vendas e tendências de consumo para ajustar a quantidade de compras.

**Cliente**
Perfil: Consumidor que utiliza os serviços do supermercado para adquirir produtos e serviços, e que influencia diretamente nas operações e decisões de negócios.
Funções: Realização de compras. Interação com o sistema durante o gerenciamento de fila no açougue.Feedback sobre a experiência de compra, qualidade do atendimento e produtos.

**Fornecedor**
Perfil: Empresas ou produtores que fornecem produtos ao supermercado para revenda ao consumidor final.
Funções: Oferta de produtos e envio de catálogos e cotações ao setor de compras do supermercado.
Atendimento aos pedidos feitos pela equipe de compras, respeitando prazos e quantidades.
