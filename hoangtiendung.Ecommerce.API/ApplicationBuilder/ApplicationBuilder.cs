namespace hoangtiendung.Ecommerce.API.ApplicationBuilder
{
    public static class ApplicationBuilder
    {
        public static void UseApplicationBuilder(this IApplicationBuilder applicationBuilder, bool IsDevelopment)
        {
            // Configure the HTTP request pipeline.
            if (IsDevelopment)
            {
                applicationBuilder.UseSwagger();
                applicationBuilder.UseSwaggerUI();
            }

            applicationBuilder.UseHttpsRedirection();

            applicationBuilder.UseAuthorization();
        }
    }
}
