programa
{

    funcao inicio()
    {
        inteiro idade , tempo_trabalho , salario , score_idade , score_salario , score_emprego , score_clt , score_tempo_trabalho , score_divida , score_estado_civil , score_final , valor_empretismo_idade
        cadeia empregado , clt , divida , estado_civil
        real valor_idade , valor_emprestimo_idade 

        escreva("Qual a idade do cliente? ")
        leia(idade)
        escreva("Empregado ou desempregado? ")
        leia(empregado)
        escreva("É autonomo ou CLT? ")
        leia(clt)
        escreva("Quanto voce ganha? ")
        leia(salario)
        escreva("Quanto tempo trabalha? ")
        leia(tempo_trabalho)
        escreva("Tem divida ou é negativado? ")
        leia(divida)
        escreva("Qual o estado civil? ")
        leia(estado_civil)

        score_emprego = 0
        score_final = 0
        valor_emprestimo_idade = 0

        score_idade = 3*(idade - 25)
        se (salario >=5000){score_salario = 150}
        senao {score_salario = 10}
        se(empregado == "desempregado") {score_emprego = -50}
        se (clt == "autonomo") {score_clt = 100}
        senao {score_clt = 150}
        se (tempo_trabalho >= 2) {score_tempo_trabalho = 150}
        senao {score_tempo_trabalho = 100}
        se (divida == "sim") {score_divida = -400}
        senao {score_divida = 100}    
        se  (estado_civil == "solteiro") {score_estado_civil = -50}
        senao {score_estado_civil = 100}
        score_final = score_salario + score_emprego + score_clt + score_tempo_trabalho + score_divida + score_estado_civil
        escreva(score_final)

        se(idade >60)
        escreva("Foi aprovado 6 parcelas a juros de 3% ")
 	   escreva("Qual valor a ser emprestado ")
 	   	leia(valor_empretismo_idade)
 	   	valor_idade = (valor_emprestimo_idade * 3/100) + valor_emprestimo_idade
 	   	escreva(valor_emprestimo_idade)
 	   	
 	   	 
        
    }
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 898; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */