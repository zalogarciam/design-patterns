public class DataSource<T> : Subject<T>
{
    private T n;

    public void SetN(T n){
        this.n = n;
        NotifyObservers(n);
    }
}
