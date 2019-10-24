

# Generator of prime numbers
def prime_generator(init,final):
        # Use an internal function to check if n is Prime
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


# Use the generator to iterate through the prime numbers:
def main():
    
    init = int(input('\n\nEnter Initial Range Number: '))
    final = int(input('\n\nEnter Final Range Number: '))

    for n in prime_generator(init, final):
            print (n,end=" ")
    input('\n\nPress Enter to... ')
    print() 


# Run the Program

main()