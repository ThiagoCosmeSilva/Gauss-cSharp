programa
{
    funcao inicio()
    {

    		//Colocar todas variavies aqui em cima, juntas
    		inteiro idade , tempo_trabalho , salario , score_idade , score_salario , score_clt , score_tempo_trabalho , score_divida , score_estado_civil , score_final 
        	cadeia empregado , clt , divida , estado_civil
        	real valor_idade ,valor_emprestimo_idade

        	
        	score_final = 0
        	valor_emprestimo_idade = 0
		// poderia já definir elas e colocar o valor ex:
		inteiro score_emprego = 0



		//fim variaveis
        	

		
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

 

        	score_idade = 3*(idade - 25)
        	se (salario >=5000){
        		score_salario = 150
        	}
        	senao {
        		score_salario = 10
        	}
        
	    se (empregado == "desempregado") {
     	  	score_emprego = -50
     	}	
        
        	se (clt == "autonomo") {
        		score_clt = 100
        	}
	     senao {
     	   	score_clt = 150
        	}
        
	     se (tempo_trabalho >= 2) {
     	   	score_tempo_trabalho = 150
        	}
        	senao {
        		score_tempo_trabalho = 100
        	}
        
        	se (divida == "sim") {
        		score_divida = -400
        	}
        	senao {
        		score_divida = 100
        	}
        
        	se  (estado_civil == "solteiro") {
        		score_estado_civil = -50
        	}
        	senao {
        		score_estado_civil = 100
        	}

        	score_final = score_salario + score_emprego + score_clt + score_tempo_trabalho + score_divida + score_estado_civil
                
        	escreva("\n================ VARIAVEIS ================")
        	escreva("\nscore_salario.:		", score_salario)
        	escreva("\nscore_emprego.:		", score_emprego)
        	escreva("\nscore_clt.:		", score_clt)
        	escreva("\nscore_tempo_trabalho.:", score_tempo_trabalho)
        	escreva("\nscore_divida.:		", score_divida)
        	escreva("\nscore_estado_civil.:	", score_estado_civil)
        	escreva("\nscore_final.:		", score_final)
        	escreva("\n===============================")

      	se(idade >60)
      	{
        		escreva("\nFoi aprovado 6 parcelas a juros de 3% ")
	     	escreva("\nQual valor a ser emprestado ")
			leia(valor_emprestimo_idade)
	 		valor_idade = (valor_emprestimo_idade * 3/100) + valor_emprestimo_idade
	 		escreva(valor_idade)
	 	}
	 	senao se(score_final <200){
	 		escreva("\nSeu credito foi reprovado ") 
	 	}
	 	senao se(score_final >200 e score_final < 400) {
	 		escreva("\nFoi aprovado 12 parcelas a juros de 6% ")
	     	escreva("\nQual valor a ser emprestado ")
			leia(valor_emprestimo_idade)
	 		valor_idade = (valor_emprestimo_idade * 6/100) + valor_emprestimo_idade
	 		escreva(valor_idade)
	 	}
	 	senao se(score_final >=500){
	 		escreva("\nFoi aprovado 24 parcelas a juros de 3% ")
	     	escreva("\nQual valor a ser emprestado ")
			leia(valor_emprestimo_idade)
	 		valor_idade = (valor_emprestimo_idade * 3/100) + valor_emprestimo_idade
	 		escreva(valor_idade)	
	 	}
	 	
	 	
    }
}
