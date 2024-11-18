namespace rental.Domain.Interfaces.Commands;

public interface IResult
{
    int StatusCode { get; set; }
    bool Success { get; set; }
    object Data { get; set; }
    IEnumerable<string> Messages { get; set; }

    byte[] File { get; set; }
}