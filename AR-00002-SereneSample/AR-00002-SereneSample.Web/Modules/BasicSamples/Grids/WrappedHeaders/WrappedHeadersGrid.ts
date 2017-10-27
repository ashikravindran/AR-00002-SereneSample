/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace AR_00002_SereneSample.BasicSamples {

    @Serenity.Decorators.registerClass()
    export class WrappedHeadersGrid extends Northwind.OrderGrid {

        constructor(container: JQuery) {
            super(container);
        }
    }
}