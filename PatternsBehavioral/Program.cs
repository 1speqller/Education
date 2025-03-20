using PatternObserver;
using PatternObserver.Observers;

Stock stock = new Stock();

var bank = new Bank(stock);
var broker  = new Broker(stock);

stock.Market();
stock.Market();