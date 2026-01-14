namespace Application.Abstractions
{
    public interface IUseCase<in TInput, TOutput>
    {
        Task<TOutput> HandleAsync(TInput input);   
    }
}