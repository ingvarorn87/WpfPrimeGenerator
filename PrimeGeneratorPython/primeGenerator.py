


def prime_generator(init,final):
        """ Utiliza una funcion interna para comprobar si n es primo"""
        def isPrime(n):
                if n <= 1:
                        return False
                
                for i in range(2,n):
                        if n % i == 0:
                                return False
                return True

        n = init
        while(n <= final):
                if isPrime(n):
                        yield n
                n += 1


# Utilizar el generador para iterar por los n�mero primos:

def main():
    
    init = int(input('\n\nEnter init Range Number: '))
    final = int(input('\n\nEnter end Range Number: '))

    for n in prime_generator(init, final):
            print (n,end=" ")
    input('\n\nPress Enter to... ')
    print() 


# Run the Program

main()