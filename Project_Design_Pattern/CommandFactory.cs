namespace Project_Design_Pattern
{
    internal class CommandFactory
    {
        public CommandFactory()
        {

        }
        // ommand options 
        public OrderCommand DisplayOptionsMenu(int cmdoption)
        {
            switch (cmdoption)
            {
                case 1:
                    return new CreateOrderCommand();
                case 2:
                    return new UpdateOrderCommand();
                case 3:
                    return new DeleteOrderCommand();
                case 4:
                    return new RedoOrderCommand();
                default:
                    return new CreateOrderCommand();
            }
        }
    }
}
