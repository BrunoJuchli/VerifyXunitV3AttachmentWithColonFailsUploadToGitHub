namespace Repro;

public class FailingTests
{
    [Fact]
    public async Task TheFail()
    {
        var foo = "U<z<U"u8.ToArray();

        await Verify(foo);
    }
}