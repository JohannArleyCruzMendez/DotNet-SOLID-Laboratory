
using CASO5_DIP_Principio_de_Inversión_de_Dependencias.Processors;
using CASO5_DIP_Principio_de_Inversión_de_Dependencias.Services;







CourseCheckoutService payPalPayment = new CourseCheckoutService(new PayPalPaymentProcessor());

payPalPayment.ProcessCheckout(2000m);


CourseCheckoutService payStripePayment = new CourseCheckoutService(new StripePaymentProcessor());

payStripePayment.ProcessCheckout(2000m);