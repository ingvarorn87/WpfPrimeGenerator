from timeit import default_timer as timer
from multiprocessing import Pool

# Use an internal function to check if n is Prime
def prime_numer_check(num):
        if num <= 1:
                return False
  
        for i in range(2,num):
                if num % i == 0:
                        return False

        return num


# Generator of prime numbers
def secuential_prime_numbers(start_num,final_num):
        start_time = timer()
        primeList = []
        while(start_num <= final_num):
                if prime_numer_check(start_num):
                        primeList.append(start_num)
                start_num += 1   
        elapsed_time = timer() - start_time
        return '\nSecuential Method:\n', primeList, '\nElapsed Time:', elapsed_time


# Generator of prime numbers
def parallel_prime_numbers(start_num, final_num):
        start_time = timer()
        p = Pool()
        results = p.map(prime_numer_check, range(start_num, final_num+1))
        results = list (filter(False.__ne__,results))  
        p.close()
        p.join()
        elapsed_time = timer() - start_time
        return '\nParallel Method:\n', results, '\nElapsed Time:', elapsed_time



# Use the generator to iterate through the prime numbers:
def main():
        i_num = int(input('\nEnter Initial Range Number: '))
        f_num = int(input('\nEnter Final Range Number: '))    
        print('\n', *secuential_prime_numbers(i_num, f_num), '\n', *parallel_prime_numbers(i_num, f_num))
        input('\n\nPress Enter to... ')
        print() 


# Run the Program
if __name__ == "__main__":
        main()