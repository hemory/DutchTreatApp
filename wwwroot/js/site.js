



var theForm = $("#the-form");
theForm.hide();

var button = $("#buy-button");
button.on("click", function (){
    console.log("Buying item");
});


var productInfo = $(".product-props li");
productInfo.on("click", function (){
    console.log($(this).text())
})

