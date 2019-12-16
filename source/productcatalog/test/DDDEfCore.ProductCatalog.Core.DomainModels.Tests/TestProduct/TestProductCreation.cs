﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture.Xunit2;
using DDDEfCore.ProductCatalog.Core.DomainModels.Exceptions;
using DDDEfCore.ProductCatalog.Core.DomainModels.Products;
using Shouldly;
using Xunit;

namespace DDDEfCore.ProductCatalog.Core.DomainModels.Tests.TestProduct
{
    public class TestProductCreation
    {
        [Theory(DisplayName = "Create Product Successfully")]
        [AutoData]
        public void CreateProductSuccessfully(string productName)
        {
            var product = Product.Create(productName);

            product.ShouldNotBeNull();
            product.ProductId.ShouldNotBeNull();
            product.ProductId.ShouldBeAssignableTo<ProductId>();
            product.Name.ShouldBe(productName);
        }

        [Fact(DisplayName = "Create Product with Empty Name Should Throw Exception")]
        public void CreateProduct_With_EmptyName_ShouldThrow_Exception()
            => Should.Throw<DomainException>(() => Product.Create(string.Empty));
    }
}