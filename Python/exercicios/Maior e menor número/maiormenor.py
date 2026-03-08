# Código em Python para identificar o maior e o menor número a partir de um valor fornecido pelo usuário.


print("Defina dois números para descobrir qual é o maior e qual é o menor valor dentre eles: ") # Declarando as variáveis dos números que serão informadas
n1 = int(input("Primeiro número: ")) # Mensagem que aparece para o usuário e também pode escrever o número na frente. O programa converte o número para inteiro
n2 = int(input("Segundo número: ")) 
if n1 > n2: # Confere se o número "n1" é maior que o número "n2"
    print(f"Maior: {n1}")
    print(f"Menor: {n2}")
elif n2 > n1: # Confere se o número "n2 é maior que o número "n1"
    print(f"Maior: {n2}")
    print(f"Menor: {n1}")
elif n2==n1: # // Confere se os números "n1" e "n2" são iguais
    print(f"Os números {n1} e {n2} são iguais!")