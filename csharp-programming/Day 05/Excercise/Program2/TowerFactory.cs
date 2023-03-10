﻿namespace csharp_programming {
    internal class TowerFactory : IPropertyFactory {
        public IProperty CreateProperty() {
            return new Tower();
        }
    }
}
