from random import randint
print("-="*30)
print(f"{'Jogo par ou impar:':^60}")
print("-="*30)
v = 0

while True:
    jogador = input("Digite [P/I] para começar o jogo: ")
    num = int(input("Digite um número: "))
    maquina = randint(0, 10)
    soma = num + maquina
    print(f"Você jogou {num} e a maquina {maquina}, com um total de {soma}")
    if jogador == "p":
        if soma % 2 == 0:
            print("-="*30)
            print("Você ganhou!!")
            v =+ 1
            print("-="*30)
        else:
            print("-="*30)
            print("Você perdeu!!")
            print("-="*30)
            break
    elif jogador == "i":
        if soma % 2 == 0:
            print("-="*30)
            print("Você ganhou!!")
            v =+ 1
            print("-="*30)
        else:
            print("-="*30)
            print("Você perdeu!!")
            print("-="*30)
            break

print(f"Você ganhou {v} vezes!")