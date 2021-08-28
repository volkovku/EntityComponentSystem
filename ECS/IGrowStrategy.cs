namespace ECS
{
    /// <summary>
    /// Represents a grow strategy.
    /// </summary>
    public interface IGrowStrategy
    {
        /// <summary>
        /// Returns new size of array.
        /// </summary>
        /// <param name="oldSize">An old size.</param>
        /// <returns>A new size.</returns>
        int NewSize(int oldSize);
    }

    /// <summary>
    /// Represents a lineal grow strategy: new size = old size + fixed amount. 
    /// </summary>
    public class LinealGrowStrategy : IGrowStrategy
    {
        private readonly int _incAmount;

        /// <summary>
        /// Initializes a new instance of LinealGrowStrategy class.
        /// </summary>
        /// <param name="incAmount">A fixed amount of grow.</param>
        public LinealGrowStrategy(int incAmount)
        {
            _incAmount = incAmount;
        }

        /// <summary>
        /// Returns new size of array: oldSize + incAmount.
        /// </summary>
        /// <param name="oldSize">An old size.</param>
        /// <returns>A new size.</returns>
        public int NewSize(int oldSize)
        {
            return oldSize + _incAmount;
        }

        public override string ToString()
        {
            return $"LinealGrowStrategy(incAmount={_incAmount})";
        }
    }

    /// <summary>
    /// Represents a double grow strategy: new size = old size * 2.
    /// </summary>
    public class DoubleGrowStrategy : IGrowStrategy
    {
        public static readonly DoubleGrowStrategy Instance = new DoubleGrowStrategy();
        
        private DoubleGrowStrategy()
        {
        }
        
        public int NewSize(int oldSize)
        {
            return oldSize * 2;
        }

        public override string ToString()
        {
            return "DoubleGrowStrategy()";
        }
    }
}