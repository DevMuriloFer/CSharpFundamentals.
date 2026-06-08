namespace _14_Interfaces_IoC.Exceptions;

public class DomainException(string message) : Exception(message);

public class InvalidContractNumber()
    : DomainException("The contract number must be between 1 and 99999999");

public class InvalidContractValue()
    : DomainException("The contract value can't be lower than 200");